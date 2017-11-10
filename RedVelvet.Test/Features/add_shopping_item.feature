Feature: Add shopping item
    Add an item to your shopping list

Scenario: Add a shopping item
    Given I have items in my shopping list
    When I press add
    And I enter the name "red food colouring"
    And I press save
    Then I should see "red food colouring" in my shopping list    