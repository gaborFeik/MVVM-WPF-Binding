# MVVM-WPF-Binding
Using MVVM pattern for creating bound elements in WPF-, C#, XAML

Changing from Element event reactions to binding.
I'm using Caliburn.Micro package paying attention for naming convention.
I bind ItemSource paths to XAML elements with DataTemplates.I listen to OnPropertyChanged events and updating the bound elements.
There are 4 Views created with 4 corresponding ViewModels code behinds.
I also added the iTextSharp refference to convert Model data to PDF using PdfContentByte class to stream data with String,X,Y Page coordinates.
As the time elapses I'm implementing a Repository interface and entities onto an Azure SQL db.
