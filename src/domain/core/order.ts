export class Order {
  constructor(
    public id: number,
    public buyerId: number,
    public isPlaced: boolean,
    public checkoutDate: Date,
    public totalAmount: number,
    public delete_time: Date | null,
  ) {}
}
