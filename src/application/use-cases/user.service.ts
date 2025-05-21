import { Injectable } from '@nestjs/common';
import { IUserRepository } from 'src/domain/interfaces/user-repository.interface';

@Injectable()
export class UserService {
  constructor(private readonly userRepository: IUserRepository) {}

	async createUser(email:string, password:string, username:string){
		
	}
}
