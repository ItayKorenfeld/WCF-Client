   M S B A M L   `   `   `  ����H  DLoginRegister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:LoginRegister.ServiceReference1LoginRegister.ServiceReference1  5      -clr-namespace:LoginRegisterLoginRegister  5          LoginRegister.ReportList   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local1-clr-namespace:LoginRegister.ServiceReference1     5      -localclr-namespcae:LoginRegister     5      .local2clr-namespace:LoginRegister     5        N� Title$  
ReportList��5       � DataContext 5      .   (LoginRegister.ServiceReference1.Problems  5   
   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��Center=�5      $��Center=�5      $��25(�5      $��Report A Problem��5      
�������6,   �� 5!   
   $��1��6   $
��Left=�5"      $��Center=�5#      $��20(�5$      $��Select Class :��5%      
����� �6*   �� 5&   
   $��2��6   $
��Left=�5'      $��Center=�5(      $��20(�5)      $��Select tool :��5*      
����� �6)   �� 5+   
   $��3��6   $
��Left=�5,      $��Center=�5-      $��20(�5.      $��Enter description  :��5/      
����� �60   �� 5D   
   -   5         ��Name$
 cmb1��5D      $	��100��6!   $��20��6-   $��1��6:   5F      �� 5G   
   -   5        $
 cmb2��5G      $	��100��6!   $��20��6-   $��2��6:   5I      �� 5_   
   -   5         ��Name$ textBox2��5_      $��3��5`      $	��200��5a      $��23��5b       �� TextWrapping$
 Wrap=�5d         errorMessage =� ErrorTemplate# [  6&   .��6_   ��5e      �� 5f       �� Path$ Description�6    �� ValidatesOnDataErrors . 	 �� UpdateSourceTrigger$	 PropertyChanged=�5h      
 �� ValidationRules
 5i      #   LoginRegister.OnlyLettersRule  5j      5n      .��5o      5q      �� 5s   
   -   5         ��Name$ button��5s      $��4��5t      $��75��5u      $��50��5v      $
��send��5x      $��569,20,156,20q�6    �� 5y   
   -   5         ��Name$ 	textBlock��5y      $
��Wrap=�5z      $y�Hidden=�5|      $��20(�6(   $��Right=�66   
���  ��$��0,25,316,14q�6c   $	��173��6x   $��4��6�   �� 5�   
   -   5        $ button4��5�      $��4��5�      $	��114��5�      $��40��5�      $
��Left=�5�      $	��Top=�5�      $��	87,25,0,0q�5�      $
��back��5�      5�      5�      