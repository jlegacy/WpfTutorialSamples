   M S B A M L   `   `   `  ����  WpfTutorialSamples@    :WpfTutorialSamples.Common_interface_controls.ToolbarSample   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ToolbarSample��5   	   $	��200��6   $	��300��6,    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6'     5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      6(   .��5
      ]� .+�5   
   `� $	��Top=�6   .�5      c� .@�5      �� $	��New��6   $	��New��6'   �� 5      $
��Open��6   $
��Open��6(   �� 5      $
��Save��6   $
��Save��6(   5      c� 5      .@�5      �� $	��Cut��6   $	��Cut��6'    c� OverflowMode$ Always=�65   �� 5      $
��Copy��6   $
��Copy��6(   $ AsNeeded=�67   �� 5      $��Paste��6   $��Paste��6)   $ Never=�69   5      5      �� 5   
    �� AcceptsReturn . 6   5      5      