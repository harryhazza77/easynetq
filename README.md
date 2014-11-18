EasyNetQTest
============

taken from https://github.com/mikehadlow/EasyNetQTest.

Demonstrates that easynetq configures everything as follows

1 - run the subscriber - this sets up up the queue and exchange
2 - run the publisher - this sets up the exchange only

For a web process, the subscriber needs to block inside the using statement in order to receive

Recommend installing this chrome extension https://chrome.google.com/webstore/detail/rest-web-service-client/ecjfcmddigpdlehfhdnnnhfgihkmejin

then the urls to 
1 - get subscribe are /api/carrots 
2 - post publish are /api/carrots with a body of "hello"

start up both console projects and ensure the website is running then you can see messages being sent and received from the consoles and web services.