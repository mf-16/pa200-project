# Pv179 Project

## Table of Contents

- [Assignment](#assignment)
- [Milestone 1](#milestone-1)
- [Run instructions](#run-instructions)
- [Diagrams](#diagrams)

## Assignment

Develop a digital platform for the company called **BookHub**, a company that sells books of various genres. The platform should facilitate easy browsing and purchasing of books, allowing customers to sort and filter by authors, publishers, and genres. After customers create accounts, they should be able to review their purchase history, rate books, and create wishlists. Administrators should have privileges to update book details, manage user accounts, and regulate book prices.

Moreover, it is requested that the code be made available for retrieval after the completion of the **Milestone 2** phase, enabling deployment on our test server. The code should be obtained exclusively from the master branch, ensuring its reliability and stability. Additionally, we expect the application to be optimized for efficient performance. To achieve this, we require the implementation of a cache mechanism that refreshes every 10 minutes to enhance response times and overall system efficiency.

## Milestone 1

- [ ] **Create a Use-Case Diagram** and Data Model for the application.
- [ ] **Create a REST Web API** that can fetch products based on:
    - Name
    - Description
    - Price
    - Category
    - Manufacturer
- [ ] **Setup the Database** and introduce a Data Access Layer (DAL) to your project.
- [ ] **Seed the Database** with some realistic data; avoid placeholders like 'AAAA' or 'test'.
- [ ] **Make a GitLab Repository** and set the visibility as Internal (NOT PRIVATE!).
- [ ] **Divide the Work** between Team Lead and Team Members.
- [ ] **Create a README** and write basic information about how to run the application and what it consists of.
- [ ] **Create Documentation [Technical Overview]**, which can be a part of the README, including diagrams and information about the application.
- [ ] **Equal Contribution**: Each team member in a group must contribute as equally as possible. Each member should create a database entity, seed the created entity, and create CRUD operations (Web API Endpoints) related to their entity.
- [ ] **Create an Authentication Middleware** (a simple middleware using a hard-coded access token).
- [ ] **Create a Logging Middleware** that logs all incoming requests.
- [ ] **Commit Changes**: All changes should be committed to separate branches and later merged in a merge request. At least one approval from a team member is REQUIRED. The team member that approves the changes in the merge request is also responsible for them (a requirement starting in the 2nd milestone).
- [ ] **Merge Requests**: All of the Merge Requests for Milestone 1 should be merged into a branch called **Milestone 1**. After completing the milestone, make a merge request from **Milestone 1** to **master** (this way, reviewers will be able to see all the changes in one place). The Milestone 1 can be merged ONLY AFTER TEACHER APPROVES IT!

## Run Instructions

Run instructions [here](./docs/RUN_INSTRUCTIONS.md)

## Diagrams

Use Case Diagram [here](./docs/diagrams/use-case.png)

ER Diagram [here](./docs/diagrams/erd.png)
