import { Module } from '@nestjs/common';
import { ItemRepositoryImpl } from './postgreSql/item.repository';
import { UserRepositoryImpl } from './postgreSql/user.repository';
import { OrderRepositoryImpl } from './postgreSql/order.repository';
import { ReviewRepositoryImpl } from './postgreSql/review.repository';

@Module({
  providers: [
		{
			provide: 'IItemRepository',
			useClass: ItemRepositoryImpl,
		},
		{
			provide: 'IOrderRepository',
			useClass: OrderRepositoryImpl,
		},
		{
			provide: 'IReviewRepository',
			useClass: ReviewRepositoryImpl,
		},
		{
			provide: 'IUserRepository',
			useClass: UserRepositoryImpl,
		},
	],
  exports: ['IItemRepository', 'IOrderRepository', 'IReviewRepository', 'IUserRepository'],
})
export class InfrastructureModule {}
