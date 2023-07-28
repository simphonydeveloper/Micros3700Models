## Overview

The micros 3700 database has a total of 950 tables, some of which have been removed. I have created these tables into C # entities for easy use.



## Special

There are some cases where the fields in the table conflict with the C # keyword. There are some cases where the fields in the table conflict with the C # keyword. So I use the `Column `attribute to handle it.

for example:

```c#
[Column("void")]
public string void_1 {get;set;}
```

