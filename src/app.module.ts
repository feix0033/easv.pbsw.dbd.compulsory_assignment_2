import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { DataSource } from 'typeorm';
import { UsersModule } from './users/users.module';
import { ConfigModule } from '@nestjs/config';
import { DatabaseModule } from './database/database.module';
import { CatsModule } from './cats/cats.module';
import { ApplicationModule } from './application/application.module';
import { PresentationModule } from './presentation/presentation.module';
import { UserController } from './user/user.controller';

@Module({
  imports: [
    ConfigModule.forRoot({
      isGlobal: true,
      envFilePath: '.env',
    }),
    DatabaseModule,
    UsersModule,
    CatsModule,
    ApplicationModule,
    PresentationModule,
  ],
  controllers: [AppController, UserController],
  providers: [AppService],
})
export class AppModule {
  /* DI the datasource */
  constructor(private dataSource: DataSource) {}
  b;
}
