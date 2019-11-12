# TheraLang
Platform for social lang therapy projects


## Git Flow
We are using simpliest github flow to organize our work:
![Github flow](flow.png "Github flow")
We have only **master** and **feature** branches. 
After each sprint we are creating **tag** with release version using semantic versioning (X.X.X):
https://semver.org/

**Note! Contribution rules:**
1. All the commits should start from prefix *uttmm-xxx* and have a short and clear description what was done. Where *xxx* - number of the ticket. In case of subtask - *uttmm-xxx-yyy*, where *yyy* - number of the subtask.
i.e. uttmm-4510 Added tests for GetOffers method.
2. Pull request should not contain any files that is not required by task.
In case of any violations, pull request will be rejected.
