# testing-obo-flow-with-microsoft-identity-web-library

We're going to test an OAuth2 Obo Flow using the new library: Microsoft.Identity.Web.

We are building the following scenario:

![Alt Text](https://github.com/karlospn/testing-obo-flow-with-microsoft-identity-web-library/blob/master/docs/diagram.jpg)

*This repository only contains the WebApi1 and WebApi2 apps. The client application is not important to test the OBO Flow.

1 - Some client calls the WebApi 1 passing an access token.
2 - The WebApi 1 authorizes the caller uses the access token that has received from the WebApi 1 to request another access token for WebApi 2.   
3 - Web Api 1 uses the access token that has acquired to call the Web Api 2.   

Both WebApi 1 and WebApi 2 are secured using Microsoft.Identity.Web
