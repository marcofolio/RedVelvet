Feature: Delete shopping item
    Deletes an item from your shopping list

Scenario: Delete a shopping item
    Given I have items in my shopping list
    When I edit "100ml ketchup"
    And I press delete
    Then I should not see "100ml ketchup" in my shopping list       