# Payslipgenerator
This project is used to generate payslips based on given input.This project have api to fetch payslips, asp.net web api is used to creating the api.
# Usage example
Need to run api project first and do below http post request

API URL:http://localhost:5916/api/GenPaySlip/GenPaySlip .

Request Sample :
{"First_name":"rajeev","Last_name":"Sharma","Annual_salary":"600000","Super_rate":"5","Payment_start_date":"01-March to 31-March"}.

Api will generate payslip in the response.

This  project is created using layered architecture.
To test this project i have also created  a unit test project.

I have created some test method to test calculated income tax.

you need to run unit test project to  test income tax.
