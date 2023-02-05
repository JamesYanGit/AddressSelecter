# AddressSelecter
It used to select target server, some algorithms have been included.
Two main algorithms are contained. It used strategy pattern so that you can easy to extend your own algorithm.

## Interface-IAddressSelecter
The interface can be invoke directly to set the selecting algorithm.

## Iteration algorithms
The selecter will change the target server one by one.

## Random algorithms
The selecter will change the target server according to the random number.

## Config.cs
This is a configration file that has to be reset when you start. 
Now, only FTP server info can be set.
  - ftpHost is the host of the FTP server you would use.
  - ftpPort is the port of the host.
  - ftpUsername is the username of the server
  - ftpPassword is the password of the server
  - ftpDirectory is the path that you will send message to.

*Clone the selecter to your computer and add the dependence to your project.*
