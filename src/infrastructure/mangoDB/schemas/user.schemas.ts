import { Prop, Schema, SchemaFactory } from '@nestjs/mongoose';
import { HydratedDocument } from 'mongoose';

export type UserDocument = HydratedDocument<User>;

@Schema()
export class User {
  @Prop()
  username: string;

  @Prop()
  email: string;

  @Prop()
  listItem: Item[];

  @Prop()
  review: Review[];

  @Prop()
  delete_time: Date | null;
}

class Item {
  @Prop()
  name: string;

  @Prop()
  description: string;

  @Prop()
  price: number;

  @Prop({ isRequired: false })
  image_url: string;

  @Prop({ default: false })
  is_sold: boolean;
}

class Review {
  @Prop()
  reviewer_id: number;

  @Prop()
  content: string;
}

export const CatSchema = SchemaFactory.createForClass(User);
