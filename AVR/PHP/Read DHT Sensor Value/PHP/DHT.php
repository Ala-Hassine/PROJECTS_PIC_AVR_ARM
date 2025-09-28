<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>DHT11 Sensor Data Monitor</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
        body 
        {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            padding: 20px;
        }
        .container 
        {
            background: white;
            border-radius: 20px;
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1);
            padding: 40px;
            max-width: 500px;
            width: 100%;
            text-align: center;
        }
        .header 
        {
            margin-bottom: 30px;
        }
        .header h1 
        {
            color: #333;
            font-size: 2.5rem;
            margin-bottom: 10px;
        }
        .header p 
        {
            color: #666;
            font-size: 1.1rem;
        }
        .sensor-data 
        {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 20px;
            margin-bottom: 30px;
        }
        .data-card 
        {
            background: linear-gradient(135deg, #f093fb 0%, #f5576c 100%);
            color: white;
            padding: 25px;
            border-radius: 15px;
            box-shadow: 0 10px 20px rgba(0, 0, 0, 0.1);
        }
        .data-card.temperature 
        {
            background: linear-gradient(135deg, #4facfe 0%, #00f2fe 100%);
        }
        .data-card.humidity 
        {
            background: linear-gradient(135deg, #43e97b 0%, #38f9d7 100%);
        }
        .data-icon 
        {
            font-size: 3rem;
            margin-bottom: 10px;
        }
        .data-value 
        {
            font-size: 2.5rem;
            font-weight: bold;
            margin: 10px 0;
        }
        .data-label 
        {
            font-size: 1.1rem;
            opacity: 0.9;
        }
        .last-update 
        {
            background: #f8f9fa;
            padding: 15px;
            border-radius: 10px;
            margin-bottom: 20px;
        }
        .last-update p 
        {
            color: #666;
            font-size: 0.9rem;
        }
        .refresh-btn 
        {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            border: none;
            padding: 15px 30px;
            border-radius: 50px;
            font-size: 1.1rem;
            cursor: pointer;
            transition: all 0.3s ease;
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);
        }
        .refresh-btn:hover 
        {
            transform: translateY(-2px);
            box-shadow: 0 8px 20px rgba(0, 0, 0, 0.3);
        }
        .error-message 
        {
            background: #ffeaa7;
            color: #d63031;
            padding: 20px;
            border-radius: 10px;
            margin-bottom: 20px;
            border-left: 5px solid #d63031;
        }
        .connection-status 
        {
            display: inline-block;
            padding: 8px 16px;
            border-radius: 20px;
            font-size: 0.9rem;
            margin-top: 10px;
        }
        .status-connected 
        {
            background: #55efc4;
            color: #00b894;
        }
        .status-error 
        {
            background: #fab1a0;
            color: #d63031;
        }
        @media (max-width: 768px) 
        {
            .container 
            {
                padding: 20px;
            }
            .sensor-data 
            {
                grid-template-columns: 1fr;
            }
            .header h1 
            {
                font-size: 2rem;
            }
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="header">
            <h1>🌡️ DHT11 Monitor</h1>
            <p>Real-Time Temperature & Humidity Data</p>
        </div>
        <?php
        require_once('Serial.php');
        $temperature = null;
        $humidity = null;
        $error = null;
        $status = "disconnected";
        try 
        {
            $serial = new phpSerial();
            $serialPorts = 
            [
                "COM1", "COM2"
            ];

            $connected = false;
            foreach ($serialPorts as $port) 
            {
                try 
                {
                    $serial->deviceSet($port);
                    $serial->deviceOpen();
                    $serial->confBaudRate(9600);
                    $serial->confParity("none");
                    $serial->confCharacterLength(8);
                    $serial->confStopBits(1);
                    $serial->confFlowControl("none");
                    sleep(2);
                    $serial->readPort();
                    $data = $serial->readLine();
                    if ($data !== false && !empty(trim($data))) 
                    {
                        $connected = true;
                        $status = "connected";
                        break;
                    }
                    $serial->deviceClose();
                } 
                catch (Exception $e) 
                {
                    continue;
                }
            }
            if ($connected) 
            {
                if ($data !== false && !empty(trim($data))) 
                {
                    $sensorData = explode(",", $data);
                    if (count($sensorData) >= 2) 
                    {
                        $temperature    = trim($sensorData[0]);
                        $humidity       = trim($sensorData[1]);
                        if (!is_numeric($temperature) || !is_numeric($humidity)) 
                        {
                            $error = "Invalid Data Received From Sensor";
                            $temperature = null;
                            $humidity = null;
                        }
                    } 
                    else 
                    {
                        $error = "Incomplete Data Received";
                    }
                } 
                else 
                {
                    $error = "No Data Received From Sensor";
                }
                $serial->deviceClose();
            } 
            else 
            {
                $error = "Could Not Connect To Any Serial Port ... Please Check Your Arduino Connection";
            }
        } 
        catch (Exception $e) 
        {
            $error = "Connection Error : " . $e->getMessage();
        }
        ?>
        <?php if ($error): ?>
            <div class="error-message">
                <h3>⚠️ Connection Error</h3>
                <p><?php echo htmlspecialchars($error); ?></p>
            </div>
        <?php endif; ?>
        <?php if ($temperature !== null && $humidity !== null): ?>
            <div class="sensor-data">
                <div class="data-card temperature">
                    <div class="data-icon">🌡️</div>
                    <div class="data-value"><?php echo htmlspecialchars($temperature); ?>°C</div>
                    <div class="data-label">Temperature</div>
                </div>
                <div class="data-card humidity">
                    <div class="data-icon">💧</div>
                    <div class="data-value"><?php echo htmlspecialchars($humidity); ?>%</div>
                    <div class="data-label">Humidity</div>
                </div>
            </div>
            <div class="last-update">
                <p>Last updated: <?php echo date('Y-m-d H:i:s'); ?></p>
                <span class="connection-status status-connected">● Connected</span>
            </div>
        <?php else: ?>
            <div class="sensor-data">
                <div class="data-card temperature">
                    <div class="data-icon">🌡️</div>
                    <div class="data-value">--°C</div>
                    <div class="data-label">Temperature</div>
                </div>
                <div class="data-card humidity">
                    <div class="data-icon">💧</div>
                    <div class="data-value">--%</div>
                    <div class="data-label">Humidity</div>
                </div>
            </div>
            <div class="last-update">
                <p>Waiting For Sensor Data ...</p>
                <span class="connection-status status-error">● Disconnected</span>
            </div>
        <?php endif; ?>
        <button class="refresh-btn" onclick="window.location.reload()">
            🔄 Refresh Data
        </button>
    </div>
    <script>
        setTimeout(function() 
        {
            window.location.reload();
        }, 10000);
        document.addEventListener('DOMContentLoaded', function() 
        {
            const cards = document.querySelectorAll('.data-card');
            cards.forEach(card => 
            {
                card.addEventListener('mouseenter', function() 
                {
                    this.style.transform = 'translateY(-5px)';
                });
                card.addEventListener('mouseleave', function() 
                {
                    this.style.transform = 'translateY(0)';
                });
            });
        });
    </script>
</body>
</html>
