using WebApplication.Domain.Entities;
using WebApplication.Domain.ValueObject;
using WebApplication.Infrastructure.Models;

public static class OrderMapper
{
	public static Order toDomain(this OrderDbModel orderDbModel, List<ItemMongoDbModel> itemMongoDbModels)
	{

		List<Item> orderItemList = new List<Item>();
		itemMongoDbModels.ForEach(item => orderItemList.Add(new Item
		{
			Id = new ItemId(item.Id),
			SellerId = new UserId(item.SellerId),
		}));

		return new Order
		{
			Id = new OrderId(orderDbModel.Id),
			UserId = new UserId(orderDbModel.BuyerId),
			IsCheckedout = orderDbModel.isCheckedout,
			CheckoutDate = orderDbModel.CheckoutDate,
			OrderItems = orderItemList,
			TotalPrice = orderDbModel.totalPrice,
			DeleteTime = orderDbModel.deleteDate
		};
	}

	public static OrderMongoDbModel toMongoDb(this Order order, List<Item> items)
	{

		List<ItemMongoDbModel> itemsMongoDbModals = new List<ItemMongoDbModel>();

		items.ForEach(item => itemsMongoDbModals.Add(new ItemMongoDbModel
		{
			Id = item.Id.Value,
			SellerId = item.SellerId.Value,
		}));

		return new OrderMongoDbModel
		{
			Id = order.Id.Value,
			BuyerId = order.UserId.Value,
			IsCheckedout = order.IsCheckedout,
			CheckoutDate = order.CheckoutDate,
			TotalAmount = order.TotalPrice,
			Items = itemsMongoDbModals
		};
	}
}