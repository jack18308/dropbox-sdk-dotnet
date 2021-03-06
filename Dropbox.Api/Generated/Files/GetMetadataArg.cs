// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The get metadata arg object</para>
    /// </summary>
    /// <seealso cref="AlphaGetMetadataArg" />
    public class GetMetadataArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetMetadataArg> Encoder = new GetMetadataArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetMetadataArg> Decoder = new GetMetadataArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path of a file or folder on Dropbox.</param>
        /// <param name="includeMediaInfo">If true, <see
        /// cref="Dropbox.Api.Files.FileMetadata.MediaInfo" /> is set for photo and
        /// video.</param>
        /// <param name="includeDeleted">If true, <see cref="DeletedMetadata" /> will be
        /// returned for deleted file or folder, otherwise <see
        /// cref="Dropbox.Api.Files.LookupError.NotFound" /> will be returned.</param>
        /// <param name="includeHasExplicitSharedMembers">If true, the results will include a
        /// flag for each file indicating whether or not  that file has any explicit
        /// members.</param>
        public GetMetadataArg(string path,
                              bool includeMediaInfo = false,
                              bool includeDeleted = false,
                              bool includeHasExplicitSharedMembers = false)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:(/(.|[\r\n])*|id:.*)|(rev:[0-9a-f]{9,})|(ns:[0-9]+(/.*)?))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:(/(.|[\r\n])*|id:.*)|(rev:[0-9a-f]{9,})|(ns:[0-9]+(/.*)?))\z'");
            }

            this.Path = path;
            this.IncludeMediaInfo = includeMediaInfo;
            this.IncludeDeleted = includeDeleted;
            this.IncludeHasExplicitSharedMembers = includeHasExplicitSharedMembers;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GetMetadataArg()
        {
            this.IncludeMediaInfo = false;
            this.IncludeDeleted = false;
            this.IncludeHasExplicitSharedMembers = false;
        }

        /// <summary>
        /// <para>The path of a file or folder on Dropbox.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>If true, <see cref="Dropbox.Api.Files.FileMetadata.MediaInfo" /> is set for
        /// photo and video.</para>
        /// </summary>
        public bool IncludeMediaInfo { get; protected set; }

        /// <summary>
        /// <para>If true, <see cref="DeletedMetadata" /> will be returned for deleted file or
        /// folder, otherwise <see cref="Dropbox.Api.Files.LookupError.NotFound" /> will be
        /// returned.</para>
        /// </summary>
        public bool IncludeDeleted { get; protected set; }

        /// <summary>
        /// <para>If true, the results will include a flag for each file indicating whether or
        /// not  that file has any explicit members.</para>
        /// </summary>
        public bool IncludeHasExplicitSharedMembers { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetMetadataArg" />.</para>
        /// </summary>
        private class GetMetadataArgEncoder : enc.StructEncoder<GetMetadataArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetMetadataArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteProperty("include_media_info", value.IncludeMediaInfo, writer, enc.BooleanEncoder.Instance);
                WriteProperty("include_deleted", value.IncludeDeleted, writer, enc.BooleanEncoder.Instance);
                WriteProperty("include_has_explicit_shared_members", value.IncludeHasExplicitSharedMembers, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetMetadataArg" />.</para>
        /// </summary>
        private class GetMetadataArgDecoder : enc.StructDecoder<GetMetadataArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetMetadataArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetMetadataArg Create()
            {
                return new GetMetadataArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetMetadataArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "include_media_info":
                        value.IncludeMediaInfo = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "include_deleted":
                        value.IncludeDeleted = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "include_has_explicit_shared_members":
                        value.IncludeHasExplicitSharedMembers = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
