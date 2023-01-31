# ECommercePortal

## Document:
System Requirement Specification Document

## Title:
System Reqruiement Spefication for Online Shopping Portal

## Team: 
Direct Customer,Indirect Customer, Architect,Business Analyst,	Quality Assurance Team, System Analyst

## Objective (Purpose):
The online shopping System for products Web Applictaion is intended to  provide complete solution for vendors, Consumers as well as internal users (Staff) through  a single Gateway using internet. It will enable vendors to setp up online shops, customers to browse through virtual shop and purchase products online without visiting the shop physically.

## Scope:
This System allows Shoppers to maintain thier products for adding or removing from catalog based on their availablity.
Customer will be able to  review orders history and may able to cancel order within 24 hours,order place.
The System  will be able to show live Bussion Operation statistics trends through Customized dashboard for stakeholders.

## Definitions:
	OSS: Online Shopping System
	QA:  Quality Assurance
	Portal: Peronalized Online Web Application
	MIS: Management Information System
	CRM: Customer Relation Managment
	BI:  Business Intelligence
	KPI:Key Perfomornace I
	Dashboard: Personalized information presented using  BI techniques such grid, score card, graph, KPI


## Functional Requirements:

Any annonymous User will be able to view different products avaialble for sale. Any User will be able select product to view from categories avaialble.
Registered shoppers will be able promote thier product for sale by adding  products to the product catalog maintained by System.
Staff will be able to approve or reject request for adding or removing products from product catalog by shoppers.
 Staff will be to track and maintain stock of products available for sale. Staff will be able to raise 	reqests for product updatation from product inventory.

Shopper will be able request to add new product to product catalog maintained by system.  Sales Team will be able to approve or eject request  raised by shopper for adding or removing products from product catalog.

Shopper will be able to update  product details which have been already added to product catalog.
Shoppers, sales team will be informed well in advaned about low stock  or out of stock of products in product catalog.
Product listing will be provided based their category, sale, quantity, likes, recommendations.
Consumer will be able to  add or remove products from shopping cart. System will maintain shopping cart for each consumer to maintain list of items selected by him/her. Consumer will be able view all items from shopping cart. Shopping Cart will present product details, number of items of product selected by consumer with price and total. Consumer will be able procees for Order placement.
Registered Customer will be able place an order with the help of Shopping cart maintained by system. Registered Customer will be able to cancel placed order within 24 hours. Registered customer get orders history. Registered customer can get details of order from orderes been placed. 	
Sales team will be able get details of orders of a particular Customer. Sales team  will be able to cancel , reject or approve orders been placed by consumer due to some policies of Business.
BOD will be able to summary of orders been placed , rejected from Oroder PRocessing of System. BOD will get Business insight by observing  daily operations  with the of getting orders information.
Consumer will be provided options for payment such as through internet banking  or  UPI  or Online payment option.
Consumer will asked to submit their payment related information.Consumer will be redirected to payment gateway for secure payment transaction.On successful payment processing using payment gateway system will notify consumer about transaction and order placement status.
Customer will be able track order status. Customer will be able track deliver using unique dispatcher id presented.
Customer will be able accept or return delivery based on quality received.
Delivery person will be able get delivery details sothat he / she can deliver product to customer end.
Delivery person will be able to change the status of product delivered.
Delivery vendor will be ablt to  list all product delivery to be done by their staff.
Sales team will be able to monitor shipment  done by their vendors.
Sales team will be able to track product delivery for particular customer.
Customer will able to submit feedback about product they recived. Customer will able to  get details about product orders placed.
Customer will be cancel his placed order within 24 hours. Customer will be able to update his/ her personal information. 
Customer  will be to manage his profile maintained by system. Customer will be able change his credentails if required. 
Customer will be notified about order status, delivery status through  SMS, Email communication.
Customer will get complete information about his orders, likes, comments, details through a dashboard.
Customer will be able to update his payment related information.
System will present dashboard for Customers, Vendors, Suppliers as well as BOD.
Dashboard will provide information using graph, score cards, key perfomance indicators as well Grid data prestation.
BOD will be informed about bussiness operations through reports.
Customer will be able get thier purchase realted infomation using Customer Dashboard.
Shopper will be able track thier product sale being done through online shopping portal/
	
## NonFunctional Requirement:

### Security
Registered Customer will allowed to place an order.	
Each stakeholder will be to access system  through authentication process. Who are you ?
System will provide access to  the content , operations using Role based security (Authorization) (Permissions based on Role)
Using SSL in all transactions  which will be performed stakeholder. It would protect confidential information shared by system to stake holder of Shared by stakeholder to system.
System will automatically log of  all stakeholder after some time due to inactiveness.
System will block operations for inactive  stakeholder and would redirect for authentication.
System  will internally maintain secure communiction channel between Servers ( Web Servers, App Servers, databse Server)
Sensitive data will be always encrypted across communcation.
User proper firewall to protect servers from out side fishing, velnerable attacks.


### Reliability
The system will backup business data on regular basis and recover in short time duration to keep system operational
Continous updates are matained , continous Adminstration is done to keep system operational.
During peak hours system will maintain same user experaince by managing load balacning .

### Availability
uptime:   24* 7  available  99.999%
	
### Maintainability:
A Commercial database software will be used to maintain System data Persistence.
A readymade Web Server will be installed to host online shopping portal (Web Site) to management server capabilities.
IT operations team will easily monitor and configure System using Adminstrative tools provided by Servers.
Separate enviornment will be maintained for system for isolation in  production, testing, and development.

### Portablility:
PDA: Portable Device Application
System will provide portable User Interface ( HTML, CSS, JS) through  users will be able to access online shopping portal.
System can be deployed to single server, multi server, to any OS, Cloud (Azure or AWS or GCP)

### Accessibility:
only registered customer will be able to place an order after authentication.
Sales team can reject or approve  orders, shopper requests  based on role  provided.
BOD team will be able to view daily, weekly, monthly, annual businss Growth throgh customized dashboard.
Shoppers will be able to see their product sale graph

### Durability:
System will retain customer  shopping cart for 15 minutes  even though customer loose internet connection and join again.
System will maintain wishlist for customer . customer  will be able to add products from wishlist  and add to shopping cart whenever needed.
System will implement backup and recovery for retaining stake holders data, bussiness operation data and business data over time.

### Efficiency:
on Festival season, maximum number of users  will place order, view products  with same response time.
System will be able to manage all transactions with isolation.

### Modularity:
System will designed and developed using reusable, independent or dependent business senarios in the form of modules.
These modules will be loosely coupled and highly cohesive.
System will contain CRM , Inventory , shopping cart, order processing, payment processing, Delivery module, membership and Roles managment  modules.
	
### Scalability:
System will be able  to  provide  consistent user exeprience to stake holder as well as vistors irrespective of load.

### Safety:	
online shopping portal will be secure from malicious attack, fishing.
online shoppping portal functionalilites are protected from outside with prper firewall configuration.
online shopping portal will be always kept updated with latest anit virus software.
Bussiness data will be backed up periodically to ensure safty of data using increamental back up strategy.
Role based security will be applied for Application data and operations accessibility.
