   M S B A M L   `   `   `  ����H  DLoginRegister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LoginRegisterLoginRegister  5      #    LoginRegister.HouseKeeperPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:LoginRegister     5        N� Title$  HouseKeeperPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��71* �6   �� 5      $	��60* �6   .+�5   
   �� -   5         ��Name$ txtb2��5      $��50(�6#    �� TextAlignment$ Center=�61   
�������$��2��6[   6n   �� 5   
   -   5        $
��lstv��5      $��1��6    � ContextMenu 5      �� 5      .@�5      m� -   5        $��Solved��5      6/   m� 5      -   5        $��Set Date��5      61   5       �� View 5      �� 5      .P�5      �� $��
Class Name��6\    �� Width$	 100��6p    �� DisplayMemberBinding 6%   ��  �� Path$ Classs.ClassName�6p   �� 5       $��Student Name��6]   $	 100��6s    6%   �� $ Student.FirstName�6s   �� 5"      $��	Tool Name��6d   $	 100��6w    6%   �� $ Tools.ToolName.ToolName1�6w   �� 5$      $��Description��6W   $	 100��6l    6%   �� $ Description�6l   �� 5%      $��Prob ID��6N   $	 100��6_    6%   �� $ Id�6_   �� 5&      $��Solving Time��6W   $	 100��6m    6%   �� $ SolvingTime�6m   �� 5'      $��	Is Solved��6T   $	 100��6g    6%   �� $ Issolved�6g   5(      5,      �� 51   
   -   5        	 ��Name$	 updatebt��51      $y�Hidden=�6#   $��2��67   $��554,57,138,52q�6D   $��Update Date��6[   
��� � �6�   �� 52   
   -   5        $	 cancel��52      $y�Hidden=�6!   $��2��65   $��153,49,506,43q�6B   $��cancel��6Y   
���  ��6{   &   System.Windows.Controls.Calendar  53   
   -   5        
  Name$

 clr1��53      $��325,0,268,10q�6!   $��2��67   $y�Hidden=�6D   �� 54   
   -   5        $	 button10��54      $	��155��55      $��50��56      $��Center=�57      $	��Top=�58      $��Log out��5;      
��� ���$��2��63   $��
645,55,0,0q�6@   �� 5<   
   -	   5        $	 button11��5<      $	��155��5=      $��50��5>      $��Center=�5?      $	��Top=�5@      $��
Enter Tool��5C      
�������$��2��69   $��37,55,608,0q�6F   �� 5D   
   -
   5        $	 button15��5D      $	��155��5E      $��50��5F      $��Center=�5G      $	��Top=�5H      $��
Class list��5K      
�����@�$y�Visible=�69   $��2��6N   $��334,55,311,0q�6[   5L      5M      