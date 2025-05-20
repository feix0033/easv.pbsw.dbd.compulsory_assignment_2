# easv.pbsw.dbd.compulsory-assignment-2

## Demand analysis

### ER diagram

```mermaid
---
title: ER Diagram
---
erDiagram

    User ||--o{ SaleList : "creates"
    User ||--o{ Cart : "owns"
    User ||--o{ Review : "writes"
    SaleList ||--o{ Item : "contains"
    Cart }o--|| Item : "contains"
    Review }|--|| User : "reviewer"
    Review }|--|| User : "seller"

    User {
        string user_id PK
        string email
        string password
        string username
    }

    SaleList {
        string sale_list_id PK
        string name
        string user_id FK
    }

    Item {
        string item_id PK
        string name
        text description
        string photo_id
        decimal price
        bool is_sold
        string sale_list_id FK
    }

    Cart {
        string cart_id PK
        string user_id FK
        string item_id FK
        decimal total_price
        timestamp checkout_date
    }

    Review {
        string review_id PK
        string reviewer_id FK
        string seller_id FK
        text content
    }
```

### Database Selection

根据上面的两个图表的分析, 我可以判断出下面的条件:

- review 和 item 都是独立的记录, 会存在大量重复, 并且是读取较多,写入较少的情况(当用户打开某个列表的时候, 应当加载 review 和 items). 所以把他们保存在 documenting database.
- user, order, list 之间关联较大, 较为适合存放入关系型数据库中. 他们一般写入较多.

### Data Schema and Storage Strategy

### Integration of Cloud Storage

### Caching Strategy

### CQRS Implementation

### Transaction Management
