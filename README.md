## Dungeon Master Console Game

### Overview

Welcome to the "Dungeon Master" console application, a role-playing game where you can create and manage heroes, equip them with weapons and armor.

### Necessities

First, check that you have the following:

- Visual Studio with .NET 6 installed.

### Installation

1. Clone this repository to your local pc.
2. Open the project in the IDE Visual Studio.

### Usage

### Running the App

1. Build the app in Visual Studio.
2. In Program class you can create and administer your heroes and you can also run tests for testing all the functionality.

### Creating a Hero

When creating a hero, you can choose one of these for classes:

- Wizard
- Archer
- Swashbuckler
- Barbarian

Every class has its own starting attributes, which will increase as the hero gains levels.

### Hero Attributes

Heroes have three attributes: Strength, Dexterity, and Intelligence. Attributes gains the damage for the hero. Attributes will get higher when the hero increase level.


### Equipping Gear

 Weapons and armor can be equipped. Each class can equip theire own weapons and armor.
#### Weapons

- Wizards can equip Staffs and Wands.
- Archers can equip Bows.
- Swashbucklers can equip Daggers and Swords.
- Barbarians can equip Hatchets, Maces, and Swords.

 A hero's level has to match the gear's requirements. Otherwise you will encounter exceptions.
 If you try to equip a weapon the given class can not equip, you will also encounter a exeption. 

#### Armor

- Wizards can equip Cloth.
- Archers can equip Leather and Mail.
- Swashbucklers can equip Leather and Mail.
- Barbarians can equip Mail and Plate armor.

 A hero's level has to match the gear's requirements. Otherwise you will encounter exceptions.
 If you try to equip a armor the given class can not equip, you will also encounter a exeption. 



### Calculating Stats

- TotalAttributes: Add the hero's attributes with the armor they wear to calcualte their total attributes.
- Damage: A hero's attack power is calcualted by their weapon and the sum of one the total attributes.

### Testing

This project have 67 tests to test creation of the heroes, equipment, calculations of damage and attributes and more.



