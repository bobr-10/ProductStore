   M S B A M L   `   `   `  ����E  AWPFexample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFexample.ViewsWPFexample.Views  5   	        WPFexample.Views.MakeOrder   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPFexample.Views     5   	   
�������  � Title$  	MakeOrder��5	   	   $	��576��6   $	��300��6(    � Icon$' !/Views/icons8-online-store-64.png��64    � 
ResizeMode$ NoResize=�6]   .��5
      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   ._�5      �� $
��Shop��6   ���#FF5E00$��25(�6:   $��Center=�6H   $��Center=�6c   5      �� 5   
   -   5         ��Name$ exit_Btn��5   7   $��25 0 0 0q�6   $��0q�6#   $��0��6I   $��18(�6Y   
�������$
��Left=�6z   $��Center=�6�   .��5      �� $��15��6   $��/Views/Arrow.png��6    5      � 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	OrderInfo��5      $��1��6,      AutoGenerateColumns$ False��69      
IsReadOnly$
 True��5   )   	   Columns	 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     5"      $
 Price��6)   $ * 6R    68   �� *Price+6R     5#      $
 Count��6)   $ * 6R    68   �� *Count+6R     5$      $
 Total��6)   $ * 6R    68   �� *Total+6R   5&      5'      � 5(   
   $��2��6   .+�5)      �� -   5        $��0 0 0 15q�5)      ���#FF5E00
�������$��Bottom=�5*         regular_btn#��[  60   $��
Make Order��6W   ���	#FFFF5E006�   �� 5+      -   5         ��Name$ TotalPriceOrder��5+      $��0 5 0 0q�61   ���#FF5E00$��25(�6W   $	��Top=�6e   $��Center=�6}   $��Total:��6�   5,      5-      5.      