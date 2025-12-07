# TicketApp - Angular + .NET TicketsAPI 

## Overview
This project contains:
- **TicketsAPI**: ASP.NET Core Web API returning static ticket data
- **ticket-client**: Angular standalone app fetching tickets from the API and displaying them
- Dates are shown using Angular **mediumDate** format (example: **Jun 15, 2015**)

## Project Structure
- ticket-client/ (Angular App)
- TicketsAPI/ (ASP.NET Core Web API)
- Screenshots/
  - API_Result.jpg
  - Angular_application_Result.jpg

## Ticket Fields
The API returns:
- Id  
- Short Description  
- Description  
- Created Date  
- Severity  
- Target Date  
- Status  

## How to Run

### Run the API (TicketsAPI)
Open terminal inside `TicketsAPI` and run:
- dotnet restore
- dotnet run

API URL:
- https://localhost:7146/api/tickets

### Run the Angular App (ticket-client)
Open terminal inside `ticket-client` and run:
- npm install
- ng serve

Angular URL:
- http://localhost:4200/components/tickets

## Date Format
In Angular, dates are displayed using:
- {{ t.createdDate | date:'mediumDate' }}
- {{ t.targetDate | date:'mediumDate' }}

## Screenshots
- API Output: `Screenshots/API_Result.jpg`
- Angular Output: `Screenshots/Angular_application_Result.jpg`


