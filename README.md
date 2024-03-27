Vehicle Rental Management System
Objective
The objective of this project is to design and implement a Vehicle Rental Management System using object-oriented programming principles. This application practices inheritance, abstraction, and encapsulation, developing classes to represent various types of vehicles and a rental agency.

Features
Vehicle Class (Vehicle.cs)
Represents a generic vehicle available for rental.
Properties include Model, Manufacturer, Year, and RentalPrice.
Methods for setting and getting vehicle properties.
DisplayDetails() method to display vehicle information.
Car Class (Car.cs)
Inherits from Vehicle class.
Additional properties: Seats, EngineType, Transmission, and Convertible.
Overridden DisplayDetails() method for car-specific details.
Truck Class (Truck.cs)
Inherits from Vehicle class.
Additional properties: Capacity, TruckType, and FourWheelDrive.
Overridden DisplayDetails() method for truck-specific details.
Motorcycle Class (Motorcycle.cs)
Inherits from Vehicle class.
Additional properties: EngineCapacity, FuelType, and HasFairing.
Overridden DisplayDetails() method for motorcycle-specific details.
RentalAgency Class (RentalAgency.cs)
Manages a fleet of vehicles.
Fleet array to store vehicle instances.
TotalRevenue property to track the agency's earnings.
Methods to add, remove, and rent vehicles.
Guidelines
Inheritance
Hierarchy of classes with Car, Truck, and Motorcycle inheriting from Vehicle.
Subclasses extend functionality with specific properties and methods.
Abstraction
DisplayDetails() method defined in Vehicle and overridden in subclasses.
Encapsulation of properties and methods to hide internal implementation.
Encapsulation
Class properties made private with public methods for access and modification.
Methods ensure data integrity with validations and operations.
