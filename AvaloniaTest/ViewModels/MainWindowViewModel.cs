using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using AvaloniaTest.Views;
using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;


namespace AvaloniaTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        _registers.Add(new(0, "FW_VER_MAJOR", "R"));
        _registers.Add(new(1, "FW_VER_MINOR", "R"));
        _registers.Add(new(2, "FW_STATUS_TRIG", "W"));
        _registers.Add(new(3, "OPERATION_ENABLE", "RW"));
        _registers.Add(new(4, "FAULTS_MASK", "RW"));
        _registers.Add(new(5, "OPERATION_STATUS", "R"));
        _registers.Add(new(6, "CHKS_ERR_CNT", "R"));
        _registers.Add(new(8, "IN_UNDERV_TRESH1", "RW"));
        _registers.Add(new(9, "IN_UNDERV_TRESH2", "RW"));
        _registers.Add(new(10, "OUT_OVERV_TRESH1", "RW"));
        _registers.Add(new(12, "TF1_RST", "W"));
        _registers.Add(new(13, "TF1_COEFF_A0", "RW"));
        _registers.Add(new(14, "TF1_COEFF_A1", "RW"));
        _registers.Add(new(15, "TF1_COEFF_A2", "RW"));
        _registers.Add(new(16, "TF1_COEFF_B1", "RW"));
        _registers.Add(new(17, "TF1_COEFF_B2", "RW"));
        _registers.Add(new(20, "TF2_RST", "W"));
        _registers.Add(new(21, "TF2_COEFF_A0", "RW"));
        _registers.Add(new(22, "TF2_COEFF_A1", "RW"));
        _registers.Add(new(23, "TF2_COEFF_A2", "RW"));
        _registers.Add(new(24, "TF2_COEFF_B1", "RW"));
        _registers.Add(new(25, "TF2_COEFF_B2", "RW"));
        _registers.Add(new(28, "DAC1_VALUE_SRC", "RW"));
        _registers.Add(new(29, "DAC2_VALUE_SRC", "RW"));
        _registers.Add(new(30, "DAC1_VALUE", "RW"));
        _registers.Add(new(31, "DAC2_VALUE", "RW"));
        _registers.Add(new(36, "ADC_CH0_VALUE", "R"));
        _registers.Add(new(37, "ADC_CH1_VALUE", "R"));
        _registers.Add(new(38, "ADC_CH2_VALUE", "R"));
        _registers.Add(new(39, "ADC_CH3_VALUE", "R"));
        _registers.Add(new(40, "ADC_CH4_VALUE", "R"));
        _registers.Add(new(41, "ADC_CH5_VALUE", "R"));
        _registers.Add(new(42, "ADC_CH6_VALUE", "R"));
        _registers.Add(new(43, "ADC_CH7_VALUE", "R"));
        _registers.Add(new(48, "DISCRETE_IN_LINES", "R"));
        _registers.Add(new(49, "FAULT_1_FREQ", "R"));
        _registers.Add(new(50, "FAULT_2_FREQ", "R"));
    }

    [RelayCommand]
    public void OnTestButtonClick()
    {
        Registers[0].Name = "CHECK";
    }

    [ObservableProperty]
    private ObservableCollection<Register> _registers = [];

}


public class Register(int address, string name, string access)
{
    public int Address { get; set; } = address;
    public string Name { get; set; } = name;
    public string Access { get; set; } = access;
    public string DeviceValue { get; set; } = "";
    public string UserValue { get; set; } = "";
}