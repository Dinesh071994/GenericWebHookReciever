  Clone the application and build the app and run it.
  Add a Debug point in Webhook handler to see the incoming  event
  Using Postman make a Post request
  https://localhost:44368/api/webhooks/incoming/genericjson/?code=1388a6b0d05eca2237f10e4a4641260b0a08f3a5
  Here is the sample json paylod for post request
  {
  "eventType": "AGENT_JOINED",
  "messageType": "SYSTEM",
  "conversationId": "ID-0",
  "timestamp": null,
  "agentId": "string",
  "agentName": "string"
}
  
