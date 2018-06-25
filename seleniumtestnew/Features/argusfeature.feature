Feature: ArgusMediaRegister
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Verify that a user can register an interest with Argus Media 
	Given i am on argus home page 
	When i select what market i am looking for 
	Then i should be able to register successfully 


	