   M S B A M L   `   `   `  ����H  DLoginRegister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:LoginRegister.ServiceReference1LoginRegister.ServiceReference1  5      -clr-namespace:LoginRegisterLoginRegister  5      '    !LoginRegister.RegisterHouseKeeper   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local1-clr-namespace:LoginRegister.ServiceReference1     5      -localclr-namespcae:LoginRegister     5      .local2clr-namespace:LoginRegister     5        N� Title$  RegisterHouseKeeper��5       � DataContext 5      1   +LoginRegister.ServiceReference1.HouseKeeper  5   
   .��5      � 
�����_� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��Center=�5      $��Center=�5       $��25(�5!      $��Register-HouseKeeper��5"      
�������60   �� 5$   
   $��1��6   $
��Left=�5%      $��Center=�5&      $��20(�5'      $��Enter first name :��5(      
������6.   �� 5)   
   $��2��6   $
��Left=�5*      $��Center=�5+      $��20(�5,      $��Enter last name :��5-      
������6-   �� 5.   
   $��3��6   $
��Left=�5/      $��Center=�50      $��20(�51      $��Enter password :��52      
������6,   �� 53   
   $��4��6   $
��Left=�54      $��Center=�55      $��20(�56      $��Enter phonenumber :��57      
������6/   �� 58   
   $��5��6   $
��Left=�59      $��Center=�5:      $��20(�5;      $��Enter id nuber :��5<      
������6,   �� 5=   
   $��6��6   $
��Left=�5>      $��Center=�5?      $��20(�5@      $��Enter school id :��5A      
������6-   �� 5B   
   $��7��6   $
��Left=�5C      $��Center=�5D      $��20(�5E      $��Enter join date :��5F      
������6.   �� 5G   
   -   5         ��Name$ textBox��5G      $��1��5H      $	��200��5I      $��23��5J       �� TextWrapping$
 Wrap=�5L         errorMessage =� ErrorTemplate# [  6&   .��6_   ��5N      �� 5O       �� Path$ 	FirstName�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5Q      	 �� ValidationRules	 5R      #   LoginRegister.OnlyLettersRule  5S      5V      .��5W      5Y      �� 5\   
   -   5        $ textBox1��5\      $��2��5]      $	��200��5^      $��23��5_      $
 Wrap=�5a      # [  6&   .��6_   ��5b      �� 5c      $ LastName�6    . $ PropertyChanged=�5e      	 5f        5g      5j      .��5k      5m      G� 5n   
   -   5        
 G�Name$
 passwordBox��5n      $��3��5o      $	��200��5p      $��25��5q       G� Password$  ��5r      # [  6"   5v      �� 5w   
   -   5        $ textBox2��5w      $��4��5x      $	��200��5y      $��23��5z      $
 Wrap=�5|      # [  6&   .��6_   ��5}      �� 5~      $ PhoneNumber�6    . $ PropertyChanged=�5�      	 5�      !   LoginRegister.NoLettersRule  5�          LoginRegister.ExactLength1  5�      5�      .��5�      5�      �� 5�   
   -   5        $ textBox3��5�      $��5��5�      $	��200��5�      $��23��5�      $
 Wrap=�5�      # [  6&   .��6_   ��5�      �� 5�      $ Realid�6    . $ PropertyChanged=�5�      	 5�        5�         LoginRegister.ExactLength  5�      5�      .��5�      5�      �� 5�   
   -   5        $ textBox4��5�      $��6��5�      $	��200��5�      $��23��5�      $
 Wrap=�5�      # [  6&   .��6_   ��5�      �� 5�      $ School�6    . $ PropertyChanged=�5�      	 5�        5�      5�      .��5�      5�      �� 5�   
   -   5        $ textBox5��5�      $��7��5�      $	��200��5�      $��23��5�      $
 Wrap=�5�      # [  6&   .��6_   ��5�      �� 5�      $ JoinDate�6    . $ PropertyChanged=�5�      	 5�      5�      .��5�      5�      �� 5�   
   -   5         ��Name$ button��5�      $��7��5�      $��50��5�      $
��send��5�      $��676,40,32,0q�6    $��2��65    J� RenderTransformOrigin$ 0.576,0.476&�6F   �� 5�   
   -	   5         ��Name$ 	textBlock��5�      $��7��5�      $
��Wrap=�5�      $y�Hidden=�5�      $��20(�6(   $��Right=�66   
���  ��6R   �� 5�   
   -
   5        $ button4��5�      $��8��5�      $	��120��5�      $��30��5�      $
��Left=�5�      $	��Top=�5�      $��	10,10,0,0q�5�      $��Navigate To Menu��5�      5�      5�      