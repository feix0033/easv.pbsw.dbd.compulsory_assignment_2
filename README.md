# easv.pbsw.dbd.compulsory-assignment-2

## Scenario

Design and implement the backend of an e-commerce platform specializing in second-hand items.

The platform allows users to

- List items for sale
- Browse listings
- Place orders
- Review sellers

## Demand analysis

### Structured Analysis

```mermaid
---
title: DFD 0
---
flowchart LR

    u[user]

    a[auth service]
    l[listing service]
    o[order service]
    r[review service]

    ad[[auth database]]
    ld[[listing database]]
    od[[order database]]
    rd[[review database]]

    u -->|login| a -->|login| ad
    u -->|logout| a -->|logout| ad

    r -->|link the user with review| a
    u -->|Review seller| r <--> rd

    u -->|Browse listing| l <--> ld
    u -->|list itme for sale| l

    o -->|update items after order paid| l
    u -->|Place order| o <--> od



    subgraph Level1 [listing item for sale]
        direction TB
        user(user)
        list(list)
        user -->|add itmes in list|list
    end

```

### ER diagram

```mermaid
---
title: ER Diagram
---
erDiagram
    Users {
        int id PK
        string nickname
        string email
        string password
        string address
        string paymentMethod
    }

    Lists {
        int id PK
        int sellId FK
        int[] itemsId FK
        boolean isEmptyList
    }

    Items {
        int id PK
        string name
        decimal price
        boolean soldOut
        string imgUrl
    }

    Reviews {
        int id PK
        int reviewerId FK
        int sellerId FK
        string review
    }

    Order {
        int id PK
        int userId FK
        string items
        decimal totalPrice
        boolean isPaid
        string paymentMethod
        boolean isDelivered
        string deliverAddress
    }

    Users ||--o{ Lists : "Create"
    Users ||--o{ Order : "Make"
    Users ||--o{ Reviews : "Write"
    Lists ||--o{ Items : "Have"
    Order }o--|| Items : "Include"
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
