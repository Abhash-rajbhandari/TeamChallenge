Feature: TeamChallenge

Scenario: SuperAdminUSer - Does the Motion portal take me to the new admin portal
Given I am a Super user and I log into the motion portal 
Then I see Challenges on the left tool bar with View Challenges and Create Challenge Tabs
When I click on View Challenges
Then a new Tab is openned and I see View Challanges Page on the New Tab
When I click on the first tab for the old portal I see the original page I started on.
Then I click on "Create Challenges"
And I see the "Create Challenges" page of the new portal
And I see multiple tab's for the old and new portal.

Scenario: CSAdmin - Does the Motion portal take me to the new admin portal
Given I am a CSAdmin and I log into the motion portal 
Then I see Challenges on the left tool bar with View Challenges and Create Challenge Tabs
When I click on View Challenges
Then a new Tab is openned and I see View Challanges Page on the New Tab
When I click on the first tab for the old portal I see the original page I started on.
Then I click on "Create Challenges"
And I see the "Create Challenges" page of the new portal
And I see multiple tab's for the old and new portal.

Scenario: ClientAdmin - Does the Motion portal take me to the new admin portal
Given I am a ClientAdmin and I log into the motion portal 
Then I see Challenges on the left tool bar with View Challenges and Create Challenge Tabs
When I click on View Challenges
Then a new Tab is openned and I see View Challanges Page on the New Tab
When I click on the first tab for the old portal I see the original page I started on.
Then I click on "Create Challenges"
And I see the "Create Challenges" page of the new portal
And I see multiple tab's for the old and new portal.