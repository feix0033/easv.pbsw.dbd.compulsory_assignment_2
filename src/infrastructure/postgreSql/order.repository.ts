import { Injectable } from '@nestjs/common';
import { Order } from 'src/domain/core/order';
import { IOrderRepository } from 'src/domain/interfaces/order-repository.interface';

@Injectable()
export class OrderRepositoryImpl implements IOrderRepository {
  async getAllOrderEntity(): Promise<Order> {
    throw new Error('Method not implemented.');
  }
  async getOrderEntityById(id: number): Promise<Order> {
    throw new Error('Method not implemented.');
  }
  async creatOrderEntity(order: Order): Promise<Order> {
    throw new Error('Method not implemented.');
  }
  async updateOrderEntity(order: Order): Promise<Order> {
    throw new Error('Method not implemented.');
  }
  async deleteOrderEntity(order: Order): Promise<boolean> {
    throw new Error('Method not implemented.');
  }
}
