Feature: Mark as bought
    (Un)marks a shopping item as bought in your shopping list

Scenario Outline: Mark as bought
    Given I have items in my shopping list
    When I edit <item>
    And I press as bought
    And I press save
    Then I should see <item> marked as <state> in my shopping list

    Examples:
        |  item                     |  state |
        | "250g plain flour"        | 1      |
        | "40g cocoa powder"        | 1      |
        | "300g granulated sugar"   | 0      |
        | "400g icing sugar"        | 1      |