   M S B A M L   `   `   `  ����H  DAutoGarage2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AutoGarage2._0.ViewsAutoGarage2._0.Views  5      (    "AutoGarage2._0.Views.ListOrderView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AutoGarage2._0.Views     5      
�������  J� Opacity$	  0.7Q�5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
ListOrders��5      $��1��6'   $��3��67      AutoGenerateColumns .     AlternatingRowBackground
 �����   CanUserAddRows .  $   HorizontalScrollBarVisibility$
 Auto=�6�    �� SelectedItem 6�   �� 	 �� Path$	 SelectedOrder�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Factuur Nummer��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� $	 InvoiceNumber�  5      $ 
Order Time��6%    69   �� $	 	OrderTime� �� StringFormat$ d��  5       $ Customer Name��6%    6<   �� $	 CustomerModel.FullName�4  .System.Windows.Controls.DataGridTemplateColumn  5!      $ Services��6)      MinWidth$	 100Q�6;      CellTemplate 5"      �� 5#      .R�5$      �� ��6'   �� $	 ServiceModels���5%   "   �� 5&   &   .R�5'   *   ��  �� Orientation$ 
Horizontal=�65   .+�5(   .   �� ��66   �� *Description+�� 5)   .   $�� ��68   �� 5*   .   ��66   �� *Cost+�� 5+   .   $	��€��68   5,   +   5-   '   5/      50      52      54      �� 55   
   -   5         ��Name$ ExportOrdersPdf��55      $��3��6*   $��2��6:   .��6G   Change57      58      59      