import { Module } from '@nestjs/common';
import { ItemController } from './controller/item/item.controller';
import { ReviewController } from './controller/review/review.controller';
import { OrderController } from './controller/order/order.controller';
import { UserController } from './controller/user/user.controller';

@Module({
  controllers: [
    UserController,
    ItemController,
    ReviewController,
    OrderController,
  ],
})
export class PresentationModule {}
