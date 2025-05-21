export class Review {
  constructor(
    public id: number,
    public reviewerId: number,
    public sellerId: number,
    public content: string,
    public delete_time: Date | null,
  ) {}
}
