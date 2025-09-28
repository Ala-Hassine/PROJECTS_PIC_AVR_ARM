<?php
class phpSerial
{
    protected $_device;
    protected $_handle;
    protected $_dState;
    protected $_buffer;
    protected $_os;
    public $autoFlush = true;
    public function __construct()
    {
        $this->_device  = "";
        $this->_handle  = null;
        $this->_dState  = 0;
        $this->_buffer  = "";
        $this->_os      = php_uname();
        setlocale(LC_ALL, "en_US");
    }
    public function deviceSet($device)
    {
        $this->_device = $device;
    }
    public function confBaudRate($brate)
    {
        if (!is_int($brate)) 
        {
            trigger_error("Baud Rate Must Be An Integer", E_USER_ERROR);
            return;
        }
        $this->_dState = $brate;
    }
    public function confParity($parity)
    {
        if ($parity != "none" && $parity != "even" && $parity != "odd") 
        {
            trigger_error("Parity Must Be None, Even, Or Odd", E_USER_ERROR);
            return;
        }
        $this->_dState .= "," . $parity;
    }
    public function confCharacterLength($length)
    {
        if (!is_int($length) || $length < 5 || $length > 8) 
        {
            trigger_error("Character Length Must Be An Integer Between 5 And 8", E_USER_ERROR);
            return;
        }
        $this->_dState .= "," . $length;
    }
    public function confStopBits($bits)
    {
        if ($bits != 1 && $bits != 2) 
        {
            trigger_error("Stop Bits Must Be 1 Or 2", E_USER_ERROR);
            return;
        }
        $this->_dState .= "," . $bits;
    }
    public function confFlowControl($flow)
    {
        if ($flow != "none" && $flow != "rts/cts") 
        {
            trigger_error("Flow Control Must Be None Or rts/cts", E_USER_ERROR);
            return;
        }
        $this->_dState .= "," . $flow;
    }
    public function deviceOpen()
    {
        $this->_handle = fopen($this->_device, "w+");
        if (!$this->_handle) 
        {
            trigger_error("Device Open Failed : " . $this->_device, E_USER_ERROR);
            return false;
        }
        stream_set_blocking($this->_handle, 0);
        $this->_buffer = "";
        return true;
    }
    public function deviceClose()
    {
        if ($this->_handle) 
        {
            fclose($this->_handle);
            $this->_handle = null;
        }
    }
    public function sendMessage($message)
    {
        if (!$this->_handle) 
        {
            trigger_error("Device Must Be Opened To Send Message", E_USER_ERROR);
            return;
        }
        fwrite($this->_handle, $message);
        if ($this->autoFlush) 
        {
            $this->serialFlush();
        }
    }
    public function readPort($count = 0)
    {
        if (!$this->_handle) 
        {
            trigger_error("Device Must Be Opened To Read It", E_USER_ERROR);
            return false;
        }
        if ($count > 0) 
        {
            $content = fread($this->_handle, $count);
        } 
        else 
        {
            $content = fread($this->_handle, 1);
        }
        return $content;
    }
    public function readLine()
    {
        if (!$this->_handle) 
        {
            trigger_error("Device Must Be Opened To Read It", E_USER_ERROR);
            return false;
        }
        $line = '';
        while (($char = fread($this->_handle, 1)) !== false) 
        {
            if ($char === "\n" || $char === "\r") 
            {
                if (!empty($line)) 
                {
                    break;
                }
            } 
            else 
            {
                $line .= $char;
            }
            usleep(10000);
        }
        return $line;
    }
    public function serialFlush()
    {
        if (!$this->_handle) 
        {
            trigger_error("Device Must Be Opened To Flush It", E_USER_ERROR);
            return;
        }
        fflush($this->_handle);
    }
}
?>