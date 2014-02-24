﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.jpush.api.common
{
    abstract class BaseResult
    {
        public const  int ERROR_CODE_NONE = -1;
        public const int ERROR_CODE_OK = 0;
        public const String ERROR_MESSAGE_NONE = "None error message.";
        
        protected const int RESPONSE_OK = 200;

        private ResponseResult responseResult;

        public ResponseResult ResponseResult
        {
            get { return responseResult; }
            set { responseResult = value; }
        }
    
        public abstract bool isResultOK();
    
        public abstract int getErrorCode();
    
        public abstract String getErrorMessage();
    
        public int getRateLimitQuota() {
            if (null != responseResult) {
                return responseResult.rateLimitQuota;
            }
            return 0;
        }
    
        public int getRateLimitRemaining() {
            if (null != responseResult) {
                return responseResult.rateLimitRemaining;
            }
            return 0;
        }
    
        public int getRateLimitReset() {
            if (null != responseResult) {
                return responseResult.rateLimitReset;
            }
            return 0;
        }

        public ResponseResult getResponseResult() 
        {
            return this.responseResult;
        }
    }
}
