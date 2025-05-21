import { Review } from '../../domain/core/review';

export interface IReviewRepository {
  getAllReview(): Promise<Review>;
  getReviewById(id: number): Promise<Review>;
  creatReview(review: Review): Promise<Review>;
  updateReview(review: Review): Promise<Review>;
  deleteReview(review: Review): Promise<boolean>;
}
