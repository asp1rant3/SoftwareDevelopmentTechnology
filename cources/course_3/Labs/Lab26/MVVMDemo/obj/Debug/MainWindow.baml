   M S B A M L   `   `   `  ����C  ?MVVMDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MVVMDemoMVVMDemo  5   	       MVVMDemo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6L   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,	viewmodelclr-namespace:MVVMDemo     5   	     � Title$  MVVM для ТРПО��5      $	��300��6   $	��300��6(    � 	Resources 5         MVVMDemo.ViewModel   	ViewModel&    MVVMDemo.DatetimeToDateConverter  MyConverter��%:   &	        &	        5   
   6     5	   
   6,   5
      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $
��Name��61   $��Center=�6=   �� 5   
   $��0��6   $��1��6   $	��100��6/   $��Center=�6;   ��6X   �� *Student.Name+ �� Mode$ TwoWay=��� 5   
   $��1��6   $��0��6!   $	��Age��61   $��Center=�6<   �� 5   
   $��1��6   $��1��6   $	��100��6/   $��Center=�6;   ��6X   �� *Student.Age+$ TwoWay=��� 5   
   $��Submit��6   $��Right=�6D   $��2��6`   $��0��6m   ��6"   �� *SubmitCommand+6m   �� 5      $��3��6,   $��1��69   $	��200��6I   ��6   �� *
Students+ �� View 5      �� 5   
   .P�5      �� $
��Name��6    �� Width$ 60��6Q   	 �� DisplayMemberBinding	 6+   �� *Name+6Q   �� 5       $	��Age��6   $ 60��6P   	 6+   �� *Age+6P   �� 5!      $��Joining Date��6   $ 80��6�   	 64   �� *JoiningDate+
 �� 	Converter#
 [ 6�   5"      5$      5%      5&      