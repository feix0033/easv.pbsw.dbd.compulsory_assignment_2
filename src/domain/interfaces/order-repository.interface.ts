import { Order } from '../../domain/core/order';

export interface IOrderRepository {
  getAllOrderEntity(): Promise<Order>;
  getOrderEntityById(id: number): Promise<Order>;
  creatOrderEntity(order: Order): Promise<Order>;
  updateOrderEntity(order: Order): Promise<Order>;
  deleteOrderEntity(order: Order): Promise<boolean>;
}
