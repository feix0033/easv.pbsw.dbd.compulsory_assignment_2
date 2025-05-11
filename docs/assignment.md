# Compulsory Assignment 2: Databases for Developers

Opened: Tuesday, 29 April 2025, 12:00 AM
Due: Wednesday, 14 May 2025, 11:59 PM
***

## Introduction

This is the second compulsory assignment of the course "Databases for Developers". To be eligible for the final exam, you must complete this assignment and have it approved. The assignment can be carried out in groups of up to 4 students. The submission deadline for this assignment is 14 May 2025 at 23:59.

## Requirements

Your assignment must satisfy the following requirements:

The implementation must clearly demonstrate contributions from every group member.
All design decisions and assumptions must be thoroughly documented in a README.md file.
The implementation must be done in a public GitHub repository.

## Scenario

Your team has been hired to design and implement the backend of an e-commerce platform specializing in second-hand items. The platform allows users to

- List items for sale
- Browse listings
- Place orders
- Review sellers

### Key design considerations include

- NoSQL Database: Efficient handling of user-generated listings, flexible schema requirements for varying item types, and rapid scalability.
- Cloud Storage: Reliable and scalable storage for item images and multimedia content.
- Caching: Improve performance by caching frequently accessed data such as item listings, user profiles, and search results.
- CQRS (Command Query Responsibility Segregation): Separate read and write operations to enhance scalability, performance, and maintainability.
- Transactions: Ensure consistency and reliability when users perform critical operations like placing an order or updating listings.

### Open-ended

The scenario is purposely open-ended to allow you to focus on parts of the application that you are interested in.

## Design & Implementation

You must clearly outline and justify your design choices addressing the following questions:

1. Database Selection: Identify and justify the selection of databases (relational and NoSQL) for various parts of your application.
2. Data Schema and Storage Strategy: Define the data models and storage strategies you will use. Clearly document how you will store and manage different kinds of data (listings, user profiles, orders, reviews).
3. Integration of Cloud Storage: Describe how you will integrate cloud storage for images and other media. Include a clear explanation of interactions between cloud storage and your databases.
4. Caching Strategy:Define your caching approach, including technologies used, cache invalidation strategy, and which data will be cached.
5. CQRS Implementation: Explain your approach to separating read and write operations, if applicable. Clarify how this impacts the application's scalability and complexity.
6. Transaction Management: Detail your approach to ensuring transactional integrity, particularly in scenarios such as orders and listing updates.

### Implementation

The implementation should primarily reflect the architecture of your solution. You are not required to implement the actual business logic, but the code should be structured in a way that allows for easy implementation of the business logic.

## Deliverables

Your deliverable for this assignment is a link to a public GitHub repository containing your completed project. The README.md file in the repository's main branch must contain comprehensive documentation of your design decisions, assumptions, and implementation details.

The git history must clearly reflect meaningful contributions from each group member.
