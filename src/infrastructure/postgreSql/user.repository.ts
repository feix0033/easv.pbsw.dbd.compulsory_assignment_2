import { User } from 'src/domain/core/user';
import { IUserRepository } from '../../domain/interfaces/user-repository.interface';
import { Injectable } from '@nestjs/common';

@Injectable()
export class UserRepositoryImpl implements IUserRepository {
  async getAllUserEntity(): Promise<User> {
    throw new Error('Method not implemented.');
  }
  async getUserEntityById(id: number): Promise<User> {
    throw new Error('Method not implemented.');
  }
  async creatUserEntity(user: User): Promise<User> {
    throw new Error('Method not implemented.');
  }
  async updateUserEntity(user: User): Promise<User> {
    throw new Error('Method not implemented.');
  }
  async deleteUserEntity(user: User): Promise<boolean> {
    throw new Error('Method not implemented.');
  }
}
