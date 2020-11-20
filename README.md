# Avanade Login Test App

## Technical profile.

This app was built using:
* MVVMCross
* AcrUserDialogues
* FluentValidator
* PropertyChanged.Fody
* ReactiveUI

## Description
This is an application, built as resolution to Avanade's hiring test.
I have buint this sample app taking in account the best practices of a **Xamarin Classic** app architecture; such as:

* Separation of Concern
* View/ViewModel/Validation/Services layers
* Global Exception Handling.
* Flexible and extensible Data/Services validations.
* Best third party tools, that I personally enjoy working with.

## App Layers Overview
### Views
View in this project are Platform specific, the definition of a Xamarin Classic approach. It means that all the UI is build specifically in each platform, and that the the platform project should only contain UI code, or platform specific code
### Converters 
This layer is located in the core project, it lives in the binding between the Views and ViewModels, in this project it is used to mask the phone number and format the date time presentation.
### View Models
These classes are the core of the application and hold logic such as navigation, View behaviors, and basically orchestrate what and how the user command and data will interact with multiple services.
### Models
These are the representation of data used by the viewmodels. These models are the DTOs that carry the information from the ViewModels to the Service layer. These models are also able to validate themselves, I chose FluentValidator library to simplify this process.
### Validations
Validations in this project happen on the ViewModel and on the Service layer, and they are Exception Oriented. Exception oriented,means that all valitations that are not met, will throw known exceptins, which will be treated and shown to the user by the GlobalExceptionHandler service.

Service layer has the responsability of validating the information against other data and/or services. The ViewModel/Model validation validates the data input from the user
### Services
Services mainly interact with ViewModels(VMs), take in user data process it, making use of infrastructure servies or not, and finally VMs comunicating with the VM the results.
### Infrastructure Services
The infrastructure services are anything that have to be implemented on the main platforms, or services that interact with a local database, or services that comunicate with a backend server etc. These services will focus on more technology specific implementations.

## Next steps for this app
In my opinion, a successfull and clean app takes in account the following items:


* Effective UX/UI. (Animations, Transitions, Reusage of components)
* Automated CI/CD pipeline.
* Resilient connection with the web/backend server.(Retry, Circuit break, cache)
* Monitoring (AppInsights, Raygun, AppCenter).
* Unit Testing and possibly UI Testing(Nice-to-have).
* Release to public strategy (Alpha ,Beta testers).