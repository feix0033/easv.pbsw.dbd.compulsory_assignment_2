import { Injectable } from '@nestjs/common';
import { Item } from 'src/domain/core/item';
import { IItemRepository } from 'src/domain/interfaces/item-repository.interface';

@Injectable()
export class ItemRepositoryImpl implements IItemRepository {
  async getAllItemEntity(): Promise<Item[]> {
    throw new Error('Method not implemented.');
  }
  async getItemEntityById(id: number): Promise<Item> {
    throw new Error('Method not implemented.');
  }
  async creatItemEntity(item: Item): Promise<Item> {
    throw new Error('Method not implemented.');
  }
  async updateItemEntity(item: Item): Promise<Item> {
    throw new Error('Method not implemented.');
  }
  async deleteItemEntity(item: Item): Promise<boolean> {
    throw new Error('Method not implemented.');
  }
}
