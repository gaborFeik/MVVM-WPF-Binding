   M S B A M L   `   `   `  ����H  DAutoGarage2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AutoGarage2._0.ModelsAutoGarage2._0.Models  5      $    AutoGarage2._0.Views.OrderView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^ ZCaliburn.Micro.Platform, Version=3.2.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5      0Models#clr-namespace:AutoGarage2._0.Models  5      
�������  J� Opacity$	  0.7Q�5	       � 	Resources 5         serviceObject S� 
ObjectType(   "AutoGarage2._0.Models.ServiceModel��%"   &	        S� 5   
   "  63   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $
��auto �6   �� 5#      $
��auto �6   �� 5$      $��* �6   �� 5%      $��10 �6   .+�5)   
   �� $��2��6   $��1��6$   $��Select a customer��61   �� 5*   
   $��5��6   $��1��6$   $��Added services��61   $��Center=�6G   �� 5-   
   -   5         ��Name$ CustomerName��5-      $��2��6(   $��2��68   $��10q�6E   $��20��6Q   �� 5.   
   -   5         ��Name$ 
FCustomers��5.   ;   $��3��6   $��2��6"   $��10q�6/   $��70��6O   $	��150��6\   $	��170��6k    �� SelectedItem 6{   �� *SelectedCustomer+��5/      �� 50      .R�51      ��  �� Orientation$ 
Horizontal=�6!   .+�52      �� ��6    �� *	FirstName+�� 53      $�� ��6    �� 54      ��6    �� *
LastName+55      56      58      �� 5;   
   $��2��6   $��3��6$   $��Please add a service��61   $��Center=�6M   �� 5<   
   $��3��6   $��3��6$   $��Enter the cost��61   $��Center=�6G   �� 5=   
   -   5        $ Service_Description��5=      $	��100��6/   $��2��6>   $��4��6N   $��10q�6[   �� 5>   
   -   5        $ Service_Cost��5>      $	��100��6)   $��3��68   $��4��6H   $��10q�6U   �� 5?   
   -   5        	 ��Name$	 
AddService��5?      $��4��6%   $��4��65   $��10q�6B   $��50��6N   $	��150��6\   .��6k   Add6p   �� 5@   
   -   5        $	 RemoveService��5@      $��6��6(   $��2��68   $��10q�6E   $��50��6Q   $	��150��6_   .��6n   Remove6v   �� 5C   
   -   5        $ OrderServices��5C      $��5��6)   $��2��69   $��10q�6F   $	��200��6R    6a   �� *SelectedService+
 �� Mode$
 OneWayToSource=���5D      �� 5E      .R�5F      �� $ 
Horizontal=�6!   .+�5G      �� ��6"   �� *Description+�� 5H      $�� ��6$   �� 5I      ��6"   �� *Cost+�� 5J      $	��€��6$   5K      5L      5N      �� 5Q   
   $��2��6   $��5��6$   $��Factuur��61   $��Center=�6@   $��Center=�6]   �� 5R   
   -   5        $ InvoiceNumber��5R      $	��100��6)   $��3��68   $��5��6H   $��10q�6U    �� 	MaxLength$ 10��6a   �� 5U   
   -	   5        $	 	ExportPdf��5U      $��5��6$   $��7��64   $��10q�6A   $��50��6M   $	��150��6[   .��6j   Factuur PDF6w   �� 5V   
   -
   5        $	 AddOrder��5V      $��6��6#   $��7��63   $��10q�6@   $��50��6L   $	��150��6Z   .��6i   Verder6q   5Y      5Z      