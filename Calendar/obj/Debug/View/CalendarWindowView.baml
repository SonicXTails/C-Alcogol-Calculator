   M S B A M L   `   `   `  ����C  ?Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Calendar.ViewCalendar.View  5   	   "    Calendar.View.CalendarWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Calendar.View     5   	     � Title$  CalendarWindow��5   	   $	��500��6    $	��330��6-    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   
������  � AllowsTransparency . .��5      � .+�5   
   ��  �� CornerRadius$ 20��6   ���	#FF473F77
����h{�$��4q�5      ._�5       � -   5        $��	MainFrame��5        � NavigationUIVisibility$ Hidden=�6%   5      n� 5   
   -   5        $��TopLeftResizeThumb��5      $��10��5      $��9��5      ���#1b1448 � Cursor$ SizeNWSE��5      $	��Top=�5      $
��Left=�5      $y�Visible=�5       $��	-4,-3,0,0q�6%   � 5#   
    � RowDefinitions 5$      �� 5%      $��30 �6    �� 5&      .+�5)      �  � ColumnDefinitions 5*      �� 5+      �� 5,      $��20 �6'   �� 5-      $��20 �6'   �� 5.      $��5 �6'   .+�51      �� -   5        	 ��Name$	 MinimiseButton��51      ���	#FF37118E$��0q�53      $��-��54      
�������$��16(�56      $��
Montserrat)�57      $
 Hand��58      $��2��59   6   $��
0,10,15,-7q�6J   $��Right=�5:      ��5;      �� 5<      
 �� 
TargetType"
 ��6    .�5=      ��  �� Property � �� �� Value �	#FF542CAF6;    �� Triggers 5>      P� 5?   "    P� Property �@J�IsMouseOver P� Value . . �5@   &   ��  � �� �	#FF37118E6C   5A   #   5C      ��5F      �� 5G       �� 
TargetType" ��6*   .R�5H      �� $��18��6%   $��18��60   $ 9��5I   %   #��z��5J   %   ._�5K   "   �� $��Center=�63   $��Center=�5L   3   5M      5N      5P      �� 5S      -   5        $	 CloseButton��5S      
���  ��$��0q�5U      $��X��5V      
�������$��12(�5X      $��
Montserrat)�5Y      $
 Hand��5Z      $��1��5[      $��2��5\   3   $��10,10,12,-7q�6G   ��5]      �� 5^      "
 ��6    .�5_      ��  � ��
 �  ��6;    5`      P� 5a   "    �@J�IsMouseOver . . �5b   &   ��  � �� �#FFA0006C   5c   #   5e      ��5h      �� 5i      " ��6*   .R�5j      �� $��18��6%   $��18��60   $ 9��5k   %   #��z��5l   %   ._�5m   "   �� $��Center=�63   $��Center=�5n   3   5o      5p      5r      5s      5t      5u      5v      