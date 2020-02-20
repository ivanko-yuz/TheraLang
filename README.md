# TheraLang  
Platform for social lang therapy projects  
[Website](https://theralang.azurewebsites.net/)  
  
## Git Flow  
We are using simpliest github flow to organize our work:  
![Github flow](flow.png "Github flow")  
We have only **master** and **feature** branches.   
After each sprint we are creating **tag** with release version using semantic versioning (X.X.X):  
https://semver.org/  

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites
[Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) 
[Angular CLI](https://angular.io/guide/setup-local) 

### Installing
1. Clone it from git hub with $ git clone https://github.com/ivanko-yuz/TheraLang.git 
2. In project TheraLeng.Web create file appsetings.json. [Default appsettings.json](./docs/defaultappsettings.md)
3. Run TheraLang.Web project
  
**Note! Contribution rules:**  
1. All Pull Requests should start from prefix *LVIIICNET-xxx* and have a short and clear description what was done. Where *xxx* - number of the ticket. In case of subtask - *LVIIICNET-xxx-yyy*, where *yyy* - number of the subtask.  
i.e. LVIIICNET-4510 Added tests for GetOffers method.  
2. Pull request should not contain any files that is not required by task.  
In case of any violations, pull request will be rejected.