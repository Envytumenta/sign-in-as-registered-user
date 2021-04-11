Feature: SignInAsRegisteredUser
AS a registered user on Giftrete website (www.giftrete.com)
I want to be able to sign in with my account details
So that I can have access to the website

@SignInAsRegisteredUser
Scenario:  Sign in as a registered user
	Given that I am a registered user- on Giftrete website (www.giftrete.com)
	When I click on sign in button
	And  I enter my email address
	And  I enter my password
	And  I tick the remember me box (Optional)
	And I click on login to your account button
	Then I must be signed in

	@SignInAsRegisteredUserInvalidEmail
	Scenario: Sign in as a registered user invalid email
Given that user is a registered user- on Giftrete website 
When  user click on sign in button
And user enter my email address("manti@mail.com")
And user enter my password("Asernal1234")
And user tick the remember me box (Optional)
And user click on login to your account button
Then user must not be signed in