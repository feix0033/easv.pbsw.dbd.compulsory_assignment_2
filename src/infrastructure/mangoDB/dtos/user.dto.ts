export class UserDto {
  readonly username: string;
  readonly email: string;
  readonly listItem?: ItemDto[];
  readonly review?: Review[];
}

class ItemDto {
  readonly name: string;
  readonly description: string;
  readonly price: number;
  readonly image_url?: string;
  readonly is_sold?: boolean;
}

class Review {
  readonly id: number;
  readonly reviewer_id: number;
  readonly content: string;
}

