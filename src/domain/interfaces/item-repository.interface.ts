import { Item } from '../../domain/core/item';

export interface IItemRepository {
  getAllItemEntity(): Promise<Item[]>;
  getItemEntityById(id: number): Promise<Item>;
  creatItemEntity(item: Item): Promise<Item>;
  updateItemEntity(item: Item): Promise<Item>;
  deleteItemEntity(item: Item): Promise<boolean>;
}
