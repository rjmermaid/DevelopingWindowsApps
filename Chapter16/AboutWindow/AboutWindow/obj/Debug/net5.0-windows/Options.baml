   M S B A M L   `   `   `  ����F  BAboutWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AboutWindowAboutWindow  5   	       AboutWindow.Options   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )srcclr-namespace:AboutWindow     5   	     � Title$  Options��5   	   $	��345��6   $	��434��6&    � 
ResizeMode$ NoResize=�62   .��5	      �  � RowDefinitions 5
   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#C40D42.+�5      �� $��56��6    �� Left$ 0��6    
 �� Top$ 0��60   $��UniformToFill=�6?   $��Images/Banner.png��6W   �� 5       �� Right$ 10��6   $ 13��6&   $��Options��66   ���	#FFF7EFEF$��Times New Roman)�5      $��24(�6   $
��Bold"�6,   5      �� 5   
   $��1��6   
���   � � 	Resources 5      !   AboutWindow.NumberOfPlayers   NumberOfPlayers��%   &	          5      6&   5      .+�5      �� $��2��6   $ 10��6*   $ 2��6;   $	��408��6J   $	��208��6V   .@�5      �� $
��Game��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5        $��playAgainstComputerCheck��5      $��Play against computer��5      $
��Left=�6!   $��	11,33,0,0q�6<   $	��Top=�5       d� 	IsChecked 5   #   ��  �� Path$ PlayAgainstComputer�5   9   �� 5      $��Number of players��6    $
��Left=�6<   $��	10,54,0,0q�5       $	��Top=�6   �� 5!      -   5        $��numberOfPlayersComboBox��5!   u   $
��Left=�6#   $��
196,58,0,0q�6>   $	��Top=�6R   $��86��6j   ��5"      �� 	 �� Source#	 [  
 �� SelectedValue
 5#      �� $ NumberOfPlayers�5$      �� 5%      $"��Time allowed for each player��6    $
��Left=�6G   $��	10,85,0,0q�5&      $	��Top=�6   �� 5'      -   5        $��timeAllowedTextBox��5)      $
��Left=�5'   "   $��
196,87,0,0q�6=    �� TextWrapping$ WrapWithOverflow=�5(      $	��Top=�6I   $��86��6a    �� TextAlignment$ Center=�5)      ��5(   !   �� $ MinutesBeforeLoss�5)   Y   �� 5*      $��Minutes��6    $
��Left=�62   $��
287,85,0,0q�6M   $	��Top=�5+      5,      5-      �� 5.      $��Computer Player��6   .��5/      � ���	#FFE5E5E5.+�50      �� $��Skill Level��6    $
��Left=�66   $��	10,10,0,0q�51      $	��Top=�6   	� 52      -   5        $��dumbAIRadioButton��54      $
��Dumb��52   &   $
��Left=�65   $��	37,41,0,0q�53      $	��Top=�6   $
 TrueY�6,   54      	� 55      -   5        $��goodAIRadioButton��56   ,   $
��Good��55   &   $
��Left=�65   $��	37,62,0,0q�56      $	��Top=�6   6E   	� 57      -   5        $��cheatingAIRadioButton��59      $��Cheats��57   &   $
��Left=�67   $��	37,83,0,0q�58      $	��Top=�6   59      5:      5;      5<      5=      �� 5>   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��RightToLeft=�6;   .+�5?      �� -   5        $��cancelButton��5@      $��_Cancel��5?      $��22��6'   $��75��63   $��10,0,0,0q�6>   5@      �� 5A      -   5        $��okButton��5B      $	��_OK��5A      $��22��6#   $��75��6/   $��10,0,0,0q�6:   5B      5C      5D      5E      