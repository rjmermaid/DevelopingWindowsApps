   M S B A M L   `   `   `  ����F  BAboutWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AboutWindowAboutWindow  5   	       AboutWindow.StartGame   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AboutWindow     5   	     � Title$  Start New Game��5   	   $	��345��6    $	��445��6-    � 
ResizeMode$ NoResize=�69   .��5	      �  � RowDefinitions 5
   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#C40D42.+�5      �� $��56��6    �� Left$ 0��6    
 �� Top$ 0��60   $��UniformToFill=�6?   $��Images/Banner.png��6W   �� 5       �� Right$ 10��6   $ 13��6&   $��New Game��66   ���	#FFF7EFEF$��Times New Roman)�5      $��24(�6   $
��Bold"�6,   5      �� 5   
   $��1��6   
���   �5      �� 5   
   -   5         ��Name$ playerNamesListBox��5   ;   $��10,41,228,34q�6W   $��2��6m   ��6   ��  �� Path$ PlayerNames�6z   �� 5   
   -   5         ��Name$ newPlayerTextBox��5      $��247,41,10,152q�6,   $��2��6C   �� 5   
   $��
New Player��6   $��264,11,101,168q�6%   $��2��6=   �� 5   
   $��Players��6   $��10,10,380,168q�6"   $��2��69   �� 5   
   -   5        	 ��Name$	 addNewPlayerButton��5      $	��Add��6-   $��376,72,10,117q�6;   $��2��6R   6_   �� 5   
   $��3��6   
 �� Orientation$
 
Horizontal=�6"   $��RightToLeft=�6;   .+�5      �� -   5        $��cancelButton��5      $��_Cancel��5      $��22��6'   $��75��63   $��10,0,0,0q�6>   5      �� 5       -   5        $��okButton��5!      $	��_OK��5       $��22��6#   $��75��6/   $��10,0,0,0q�6:   ${�False��5!   )   5"      5#      5$      