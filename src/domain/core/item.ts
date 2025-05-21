export class Item {
  constructor(
    public id: number,
    public sellerId: number,
    public name: string,
    public description: string,
    public price: number,
    public imageUrl: string,
    public isSold: boolean,
    public delete_time: Date | null,
  ) {}
}
