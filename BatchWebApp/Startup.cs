using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BatchWebApp;
using Microsoft.Owin;
using Owin;
using Quartzmin;

[assembly: OwinStartup(typeof(Startup))]

namespace BatchWebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseQuartzmin(new QuartzminOptions()
            {
                ProductName = "Sarus Batch",
                Logo = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAEgAAAApCAMAAAChm5+KAAACOlBMVEUAAAD////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////XMC76AAAAvnRSTlMADRwCAR8qAzwsRF4miZQySuG4LUdjZluvsStJ1f/7wxlhHpqyplnk6T8EZCeIEpX9QAVXYAajODXdGkgYFXmnKdjELgxUPXOtXb78uSVti9Dz/rcKNk1PXG+Smdvl9qkdNEtxjai/1uf1UFqYm8DcN05Ywt+iZZcTbIIOB37TdzM7TFZ0gIzO2nqBiqvHzNfZdlNwjqHNI3+Pz0GDkMvFdeMkRRALUruGFhEofQjGypMPMXsUeCJuwWdVaFG6y+qTIQAAA0tJREFUeJzl0/tfS2EcB/CTnTXVWrPlrLKRtnVq66asSdFkrjWXrKVmkZRLV4pcotUcKoxQIobIJRJCCf+bp/Occ/YcPdv8zOe35/s6e5/v53mdEcT/l6hlEtGZlEbLRAPJ8hjxEyGc2Dg5+kNSHq9IQAcS5QqVOrIjS1xJaeTIG6XxScmKFMRZpdWtXpMacZ9ECmStmpfINL0BxJjC7yRJp3UgGZmmcAwZFWumWClLxvXKNrDh20mUrKPTaZXhpBzQC0aTxe4kzU6CUHJujIl1tNDR5WnXhXbyCygh66VgYFEYhBRawWBDkU5IxsaQ91NMIYkrkWzabEBSmmKybdEhKduK/wrs3P3w2bZ9x04UMih27UYdXXmFA+fIrBqRQ+3ZW5gsglT79ougygNSjOOsclUfRJ2aWre+FJVUhzx0XSXiHD6Cc+qPulzVcUGn4Zjb7dY3BqWm4x6P58RJQaqswDmyKuC4XKeahX2OtQDI3SpIbe20Z1GqE5wY3D4dLpjTZ8x8Lxi9EUqdXR4Yrl1eY8hevCT04iR2pzbe4dqVn8X26hAcIDWf43vBLLZra/cEA9qVd58P14vf6UKtG43e2NnlQUNnXLyEcXpsxSLIlX65RQS5G6/QYqg3B9fL4e3rRx3fVeaaSCotuz6ASnR81FKGdKq9Xm+fEnEGGWboRnfQuXnL7/ffDkp3hjEO0eMAjrc+U7jtu/cYkKH7wk4jZcDxjxbxEt2SinMeJHihxDs1YwwrPeScwiY/m0ecRBtxjsQBHSCNw14N0GGYx0/gPk0BPyrRxqyQvThpsV3BICOEbTfy1C9kFNwT3R2uFy+50p8xSEA7vheXgefGEoxDTKAOkF4IvTgpVxUQQaOtcpxDvFSLoOhJ6zDqjL0qKXiNOoE3b3EMSZBTqPTOTlis7xFHYyemfR+CzsxHrMNanz4H97GTBGEanxWc5i/gCYtZuO3A12+hHLRddA97Nk3MjXG97OzA4uPazX+fDOMQZI6a7wUjs83BffjB9AK708wP3P99STu2FydNzPK9YCxmcE+B3rD7wFfaErheXEC7n3bkbFn4NU85IzoEMZlmF51ltn7xYNpHRegFI8knxQOL/Y8nnFN/4/yL+Q1niNPKUyxBHwAAAABJRU5ErkJggg==",
                DefaultDateFormat = "dd.MM.yyyy",
                DefaultTimeFormat = "HH:mm:ss",
                Scheduler = Scheduler.Create().Result,
            });
        }
    }
}