import { Injectable } from '@nestjs/common';
import { Review } from 'src/domain/core/review';
import { IReviewRepository } from 'src/domain/interfaces/review-repository.interface';

@Injectable()
export class ReviewRepositoryImpl implements IReviewRepository {
  async getAllReview(): Promise<Review> {
    throw new Error('Method not implemented.');
  }
  async getReviewById(id: number): Promise<Review> {
    throw new Error('Method not implemented.');
  }
  async creatReview(review: Review): Promise<Review> {
    throw new Error('Method not implemented.');
  }
  async updateReview(review: Review): Promise<Review> {
    throw new Error('Method not implemented.');
  }
  async deleteReview(review: Review): Promise<boolean> {
    throw new Error('Method not implemented.');
  }
}
