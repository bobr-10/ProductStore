   M S B A M L   `   `   `  ����E  AWPFexample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFexample.ViewsWPFexample.Views  5   	       WPFexample.Views.Account   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPFexample.Views     5   	     � 
ResizeMode$  NoResize=�5   	   
������� � Title$ Account��5
   	   $	��576��6   $	��300��6&    � Icon$% /img/icons8-online-store-64.png��62    � 	Resources 5         textbox �� 
TargetType ��Name �� CornerRadius ��Name��%�   &	        �� 5   
   " ��6*   .R�5      �� $ Bd��5      #��z��5      
�������#��z��5      $ 3��6E   ._�5      �� $ PART_ContentHost��5      $��Center=�5      $��Stretch=�6:   5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��2* �6   �� 5      $
��0.6* �6   �� 5      $��70 �6   .+�5   
   � $��0��6   
�������	 � ColumnDefinitions	 5       �� 5!      $��* �6#   �� 5"      $��* �6#   �� 5#      $��* �6#   .+�5&      �� $��1��6   ._�5'      �� $��Sign up��6   ���#FF5E00$��25(�6A   $��Center=�6O   $��Center=�6j   5(      �� 5*      -   5        
 ��Name$
 exit_Btn��5*   ;   $��25 0 0 0q�6   $��0q�6'   $��0��6M   ���#00B0FF$��18(�6t   
�������$
��Left=�6�   $��Center=�6�   .��5+      �� $��15��6   $��/Views/Arrow.png��6$   5,      5-      � 5/   
   $��1��6   .+�50      �� $��10q�6   ._�51      �� $��/Views/sign_in_logo.png��6   $��Center=�69   $��Center=�6V   52      53      � 55   
   $��2��6    57      �� 58      �� 59      .+�5<      �� $��40��6   $	��260��6"   ���#AC8E71  placeHolder#��[ 6E   
 � Tag$ 
Enter name��6j   $��15(�6}   ���#F3F3F3$��0��6�   �� 5=      $��40��6   $	��260��6"   ���#AC8E71#��[ 6D   $ Enter password��6i   $��15(�6�   ���#F3F3F3$��1��6�   5>      � 5@   
   $��3��6   .+�5A      �� -   5          regular_btn_fill#��[ 5A      
�������$��Sign up��6R   $��30 15 30 15q�6e   6�   5B      5C      5D      