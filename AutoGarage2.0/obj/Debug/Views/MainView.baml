   M S B A M L   `   `   `  ����H  DAutoGarage2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AutoGarage2._0.ViewsAutoGarage2._0.Views  5   	   #    AutoGarage2._0.Views.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:AutoGarage2._0.Views     5   	     � WindowStartupLocation$  CenterScreen=�5      $��	Bodoni MT)�6?   $��15(�6V    J� Opacity$	 0.8Q�6d    � Title$ AutoGarage v2.0 G.Feik��5   	   $	��450��6(   $	��800��65   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   .+�5      �� -   5         ��Name$ LoadCustomerView��5      $	��100��6/   $��10q�6>   $	 0.7Q�6J   .��6Y   Nieuwe Klant��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5       � 	 � Color$	 Black��6'   
 � Offset$
 0Q�65   � 5!      $	 White��6'   $
 1Q�65   5"      5$      �� 5%      -   5        $ LoadOrderView��5%      $	��100��6,   $��10q�6;   $	 0.7Q�6G   .��6U   Nieuwe Order��5&      �� 5'      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5(      � $	 Black��6'   $
 0Q�65   � 5)      $	 White��6'   $
 1Q�65   5*      5,      �� 5-      -   5        $ LoadOrderListView��5-      $	��100��60   $��10q�6?   $	 0.7Q�6K   .��6Y   
Order List��5.      �� 5/      $ 0.5,1&�6*   $ 0.5,0&�6;   .��50      � $	 Black��6'   $
 0Q�65   � 51      $	 White��6'   $
 1Q�65   52      54      �� 55      -   5        $ LoadCustomerListView��55      $	��100��63   $��10q�6B   $	 0.7Q�6N   .��6\   
Klant List��56      �� 57      $ 0.5,1&�6*   $ 0.5,0&�6;   .��58      � $	 Black��6'   $
 0Q�65   � 59      $	 White��6'   $
 1Q�65   5:      5<      5=      �� 5@   
   -   5         ��Name$ 
ActiveItem��5@   6   $��1��6   $��2��6)   66   5B      5C      