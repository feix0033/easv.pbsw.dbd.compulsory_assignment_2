import { User } from '../../domain/core/user';

export interface IUserRepository {
  getAllUserEntity(): Promise<User>;
  getUserEntityById(id: number): Promise<User>;
  creatUserEntity(user: User): Promise<User>;
  updateUserEntity(user: User): Promise<User>;
  deleteUserEntity(user: User): Promise<boolean>;
}
