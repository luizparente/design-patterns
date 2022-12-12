using Facade.Services.Interfaces;

namespace Facade.Services {
	public class VideoService : IVideoService {
		protected readonly IVideoEncodingService _videoEncodingService;
		protected readonly ICompressionService _compressionService;
		protected readonly IDataBaseService _dataBaseService;
		// ...

		public VideoService(IVideoEncodingService videoEncodingService,
							ICompressionService compressionService,
							IDataBaseService dataBaseService) {
			this._videoEncodingService = videoEncodingService;
			this._compressionService = compressionService;
			this._dataBaseService = dataBaseService;
			// ...
		}

		public void Save(object video) {
			// Complex utilization of many services, factories, etc.
		}
	}
}
