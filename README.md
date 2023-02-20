# CSE445-Assigment1
##Part I 
+ Develop a SOAP Web service that takes a string (without spaces) as a parameter and performs following analysis of the string. The service contains two operations:
      - int  wordCount(string  str);  //  return  number  of  words  in  the  string.  You  can  assume  that  words  are separated by a single fullstop. For example hello.world has two words 
      - stringStatistics analyzeStr(string str) // return stringStatistics object. 
 
+ Develop  a Windows Forms Application to consume (access) the string analyzer web service developed 
  above. Your windows form should call above three web service methods and then display the vowel 
  count, uppercase count, and number of words in the form.
+ Develop a Web Site Application to consume (access) the string analyzer web service developed above. 
  Your  windows  form  should  call  above  three  web  service  methods and  then  display  the  vowel  count, 
  uppercase count, and number of words. Functionality is same as 2 above, but this time the client is a 
  Web Site Application. 

 
##Part II   
+ Add text encryption decryption function in your website. Following is the remote service in the ASU 
  Repository for encryption decryption operations.  
  http://venus.sod.asu.edu/WSRepository/Services/EncryptionWcf/Service.svc [20 points]. The  
  Page 4 of 5 
         following links show how this service work 
        http://venus.sod.asu.edu/WSRepository/Services/EncryptionTryIt/Sender.aspx  
+ Add the Image Verifier function in your website. You can use, e.g., the Web service 
  (https://venus.sod.asu.edu/WSRepository/Services/ImageVerifierService/Service.svc 
  ) to build your application. 
        The following link has an example as to how its functionality is used 
        http://venus.sod.asu.edu/WSRepository/Services/ImageVerifierSvc/TryIt.aspx 
+ Calling 3rd party REST API  
  Openweathermap  API  is  one  of  the  most  commonly  used  APIs  for  weather  related  information.  In  this 
  question, you will be calling the air-pollution API. As described in the following link 
  https://openweathermap.org/api/air-pollution 
  this API needs three parameters, longitude, latitude, and API_Key. You can get the API key free @ 
  https://home.openweathermap.org/users/sign_in 
  Once you get the API_KEY you will be able to call the API by passing longitude and latitude. Longitude 
  and Latitude need to be read as a user input. Once you make the API call, it will return a JSON string. NO 
  need to process the JSON string. Display the JSON data that you get in your web site application  
